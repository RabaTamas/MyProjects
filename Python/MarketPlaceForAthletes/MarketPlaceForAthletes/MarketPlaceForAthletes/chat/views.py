from django.shortcuts import render
from .models import Chat
from django.contrib.auth.decorators import login_required
from django.http import JsonResponse
from django.core.serializers import serialize
import json
# Create your views here.

# def index(request):
#     return render(request, "chat/index.html")

@login_required
def chat(request):
    #chats = serialize(format='json', queryset=Chat.GetChatByParticipant(request.user))
    #chats = Chat.GetChatByParticipant(request.user)
    #return render(request, "chat/room.html", {"sender": request.user.pk, "chats": chats})
    return render(request, "room.html", {"sender": request.user.pk})

@login_required
def getChats(request):
    #chats = serialize(format='json', queryset=Chat.GetChatByParticipant(request.user))
    chats = Chat.GetChatByParticipant(request.user)
    output = []
    for chat in chats:
        message = chat.GetMessages().last()
        last_message = {
            "message": message.content,
            "receiver": {"pk": message.receiver.pk, "name": f"{message.receiver.first_name} {message.receiver.last_name}"},
            "sender": {"pk": message.sender.pk, "name": f"{message.sender.first_name} {message.sender.last_name}"},
            "timestamp": str(message.timestamp)
        }
        output.append({
            "pk": chat.pk,
            "item": {"pk": chat.item.pk, "name": f"{chat.item.name}"},
            "participant1": {"pk": chat.participant1.pk, "name": f"{chat.participant1.first_name} {chat.participant1.last_name}"},
            "participant2": {"pk": chat.participant2.pk, "name": f"{chat.participant2.first_name} {chat.participant2.last_name}"},
            "last_message": last_message #model_to_dict(chat.GetMessages().latest('timestamp'))
        })
    
    return JsonResponse({"chats": json.dumps(output)})
    
@login_required
def getConversation(request):
    chat_id = request.GET.get('chat_id')
    print("chat_id is ", chat_id)
    chat = Chat.GetChatById(int(chat_id))
    messages = chat.GetMessages()
    output = []
    for message in messages:
        output.append({
            "message": message.content,
            "receiver": {"pk": message.receiver.pk, "name": f"{message.receiver.first_name} {message.receiver.last_name}"},
            "sender": {"pk": message.sender.pk, "name": f"{message.sender.first_name} {message.sender.last_name}"},
            "timestamp": str(message.timestamp)
        })
    messages = serialize(format='json', queryset=messages)
    return JsonResponse({"messages": json.dumps(output)})

