# -*- coding: utf-8 -*-
# Generated by Django 1.10 on 2018-10-22 14:38
from __future__ import unicode_literals

from django.db import migrations, models


class Migration(migrations.Migration):

    dependencies = [
        ('wishapp', '0001_initial'),
    ]

    operations = [
        migrations.AddField(
            model_name='wish',
            name='granted',
            field=models.BooleanField(default=False),
        ),
    ]