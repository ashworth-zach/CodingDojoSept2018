# Inside your app's models.py file
from __future__ import unicode_literals
from django.db import models
import re
EMAIL_REGEX = re.compile(r'^[a-zA-Z0-9.+_-]+@[a-zA-Z0-9._-]+\.[a-zA-Z]+$')
class UserManager(models.Manager):
    def basic_validator(self, postData):
        errors = {}
        if len(postData['firstname']) < 1:
            errors["firstname"] = "first name cannot be blank"
        if len(postData['lastname']) < 1:
            errors["lastname"] = "last name cannot be blank"
        if len(postData['email']) < 1:
            errors["email"] = "email field cannot be blank"
        if postData['firstname'].isalpha() is False:
            errors["firstname"] = "first name cannot contain numbers"
        if postData['lastname'].isalpha() is False:
            errors["lastname"] = "last name cannot contain numbers"  
        if not EMAIL_REGEX.match(postData['email']):
            errors['email']="Invalid Email Address"
        check_emails = User.objects.filter(email = postData['email'].lower())
        if len(check_emails) > 0:
            errors['email']="Email already exists"
        return errors
class User(models.Model):
    firstname = models.CharField(max_length=255)
    lastname = models.CharField(max_length=255)
    email = models.CharField(max_length=255)
    created_at = models.DateTimeField(auto_now_add=True)
    updated_at = models.DateTimeField(auto_now=True)
    # *************************
    # Connect an instance of UserManager to our User model overwriting
    # the old hidden objects key with a new one with extra properties!!!
    objects = UserManager()
    # *************************