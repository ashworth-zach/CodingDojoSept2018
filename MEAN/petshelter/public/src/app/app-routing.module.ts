import { EditpetComponent } from './editpet/editpet.component';
import { ShowpetComponent } from './showpet/showpet.component';
import { CreatepetComponent } from './createpet/createpet.component';
import { MainComponent } from './main/main.component';

import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
const routes: Routes = [
  { path: 'pets/new',component: CreatepetComponent },
  { path: 'pets/:id/edit',component: EditpetComponent },
  { path: 'pets/:id',component: ShowpetComponent },
  { path: 'pets',component: MainComponent },
  { path: '', pathMatch: 'full', redirectTo: '/pets' },
];
@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }