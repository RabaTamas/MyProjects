import json
import os
from django.conf import settings
from django.shortcuts import get_object_or_404, render, redirect
from django.contrib.auth import login, authenticate, logout, update_session_auth_hash
from .forms import UserSignUpForm, ProfileSignUpForm, CreateListingForm, EditListingForm, UserEditForm, UserPasswordChangeForm
from django.contrib import messages
from items.models import Item, ItemCondition, Sport
from django.core.paginator import Paginator
from django.contrib.auth.decorators import login_required

# Create your views here.
def get_header_images():
    image_folder = os.path.join(settings.MEDIA_ROOT, 'header_images')
    image_urls = [
        f"{settings.MEDIA_URL}header_images/{image}" for image in os.listdir(image_folder)
    ]
    return image_urls

def login_user(request):
    if request.method == "POST" :
        username = request.POST['username']
        password = request.POST['password']
        user = authenticate(request=request, username = username, password = password)
        if user:
            login(user=user, request=request)
            messages.success(request, ("You have successfully logged in!"))
            return redirect("home")
        else:
            messages.success(request, ("Login failed, please try again!"))
            return redirect("login")
    else:
        return render(request, 'login.html')
    
def about(request):
    image_urls = get_header_images()

    return render(request, 'about.html', {
        'images': json.dumps(image_urls)
    })

def home(request):
    #return render(request, 'home.html', {})

    sports = Sport.objects.all()
    conditions = ItemCondition.objects.all()


    selected_conditions = request.GET.getlist('conditions')
    selected_sports = request.GET.getlist('sports')
    search_query = request.GET.get('search')

    items = Item.objects.all()
    if search_query:
        items = items.filter(name__icontains=search_query)

    
    if selected_sports:
        items = items.filter(sport__id__in=selected_sports)
   
    if selected_conditions:
        items = items.filter(condition__id__in=selected_conditions)


    sort_option = request.GET.get('sort')

    if sort_option == 'name_asc':
        items = items.order_by('name')
    elif sort_option == 'name_desc':
        items = items.order_by('-name')
    elif sort_option == 'price_asc':
        items = items.order_by('price')
    elif sort_option == 'price_desc':
        items = items.order_by('-price')

    #paginator = Paginator(items, 8)
    #page_number = request.GET.get('page')
    #page_obj = paginator.get_page(page_number)

    
    image_urls = get_header_images()

    return render(request, 'home.html', {
        #'page_obj': page_obj,
        'items': items,
        'sports': sports,
        'conditions': conditions,
        'selected_sports': selected_sports,
        'selected_conditions': selected_conditions,
        'sort_option': sort_option,
        'images': json.dumps(image_urls)
    })

def logout_user(request):
    logout(request)
    messages.success(request, ("You have successfully logged out!"))
    return redirect("home")

def signup_user(request):
    if request.method == 'POST':
        userform = UserSignUpForm(request.POST)
        profileform = ProfileSignUpForm(request.POST)
        if userform.is_valid() and profileform.is_valid():
            user = userform.save()
            profile = profileform.save(commit=False)
            profile.user = user
            profile.save()
            
            messages.success(request, 'You have successfully registered!')
            return redirect("home")
        else:
            messages.error(request, 'An error happened!')
    userform = UserSignUpForm()
    profileform = ProfileSignUpForm()
    return render(request, "signup.html", {"userform": userform, "profileform": profileform })

def item(request, pk):
    current_item = get_object_or_404(Item, id=pk)
    
    related_items = Item.objects.filter(sport=current_item.sport).exclude(id=current_item.id)

    return render(request, 'item.html', {
        'item': current_item,
        'related_items': related_items
    })


def createlisting(request):
    if request.method == 'POST':
        itemform = CreateListingForm(request.POST, request.FILES)
        if itemform.is_valid(): 
            item = itemform.save(commit = False)
            item.advertiser = request.user.profile
            item.save()
            messages.success(request, 'You have successfully uploaded a new item!')
            return redirect("my_ads")
        else:
            messages.error(request, 'Error happened while you were uploading a new item!')
    listingform = CreateListingForm()
    return render(request, "additem.html", {"listingform": listingform})

@login_required
def my_ads(request):
    user_profile = request.user.profile
    user_items = Item.objects.filter(advertiser=user_profile)

    if request.method == "POST":
        item_ids = request.POST.getlist('item_ids')
        if item_ids:
            Item.objects.filter(id__in=item_ids, advertiser=user_profile).delete()
            messages.success(request, "Selected items were deleted successfully.")
        return redirect('my_ads')

    return render(request, 'my_ads.html', {'user_items': user_items})
    

def edit_item(request, item_id):
    item = get_object_or_404(Item, id=item_id)
    
    if request.method == 'POST':
        form = EditListingForm(request.POST, request.FILES, instance=item)
        if form.is_valid():
            form.save()
            return redirect('my_ads')
    form = EditListingForm(instance=item)
    return render(request, 'edit_item.html', {'form': form, 'item': item})

@login_required
def my_profile(request):
    user = request.user
    profile = user.profile

    if request.method == 'POST':
        user_form = UserEditForm(request.POST, instance=user)
        profile_form = ProfileSignUpForm(request.POST, instance=profile)
        
        if user_form.is_valid() and profile_form.is_valid():
            user_form.save()
            profile_form.save()
            messages.success(request, "Your profile has been updated successfully.")
            return redirect('my_profile')
        else:
            messages.error(request, "An error occurred. Please try again.")
    
    user_form = UserEditForm(instance=user)
    profile_form = ProfileSignUpForm(instance=profile)

    return render(request, 'my_profile.html', {
        'user_form': user_form,
        'profile_form': profile_form
    })

@login_required
def change_password(request):
    if request.method == 'POST':
        passwordform  = UserPasswordChangeForm(user=request.user, data=request.POST)
        if passwordform.is_valid():
            passwordform.save()
            update_session_auth_hash(request, request.user)
            return redirect('my_profile')
        else:
            messages.error(request, passwordform.error_messages)
            return redirect('change_password')
    else:
        return render(request, 'change_password.html', {'form': UserPasswordChangeForm(request.user)})