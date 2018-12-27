# -*- coding: utf-8 -*-
# Generated by Django 1.10 on 2018-10-17 14:04
from __future__ import unicode_literals

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('users', '0001_initial'),
        ('messageapp', '0002_auto_20181016_2117'),
    ]

    operations = [
        migrations.RemoveField(
            model_name='message',
            name='user',
        ),
        migrations.AddField(
            model_name='message',
            name='user',
            field=models.ManyToManyField(related_name='author', to='users.User'),
        ),
    ]
