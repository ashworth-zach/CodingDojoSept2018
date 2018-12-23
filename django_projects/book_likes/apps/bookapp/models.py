from django.db import models

class User(models.Model):
    first_name = models.CharField(max_length=255)
    last_name = models.CharField(max_length=255)    
    email = models.CharField(max_length=255)
    created_at = models.DateTimeField(auto_now_add = True)
    updated_at = models.DateTimeField(auto_now = True)
    def __repr__(self):
        return "<Blog object: {} {} {}>".format(self.first_name, self.last_name, self.email)
class Book(models.Model):
    name = models.CharField(max_length=255)
    desc = models.CharField(max_length=255)
    uploaded_by=models.ForeignKey(User, related_name='uploaded_by')
    likes = models.ManyToManyField(User, related_name="liked_by")
    created_at = models.DateTimeField(auto_now_add = True)
    updated_at = models.DateTimeField(auto_now = True)



