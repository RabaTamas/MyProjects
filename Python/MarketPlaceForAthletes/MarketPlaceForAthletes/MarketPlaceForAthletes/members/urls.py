from django.urls import path
from . import views

urlpatterns = [ 
    path('login/', views.login_user, name='login'), 
    path('home/', views.home, name='home'),
    path('logout/', views.logout_user, name='logout'),
    path('signup/', views.signup_user, name='signup'),
    path('about/', views.about, name='about'),
    path('item/<int:pk>/', views.item, name='item'),
    path('addlisting/', views.createlisting, name='addlisting' ),
    path('my-ads/', views.my_ads, name='my_ads' ),
    path('edit_item/<int:item_id>/', views.edit_item, name='edit_item'),
    path('my_profile/', views.my_profile, name='my_profile'),
    path('change_password/', views.change_password, name='change_password'),
    path('advertisers/', views.advertisers, name='advertisers'),
    path('advertisers/add_score/<int:user_id>/', views.add_score, name='add_score')
]