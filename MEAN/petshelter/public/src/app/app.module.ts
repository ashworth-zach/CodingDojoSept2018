import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { HttpService } from './http.service';
import { AppComponent } from './app.component';
import { FormsModule } from '@angular/forms'; // <-- import FormsModule.
import { AppRoutingModule } from './app-routing.module';
import { CreatepetComponent } from './createpet/createpet.component';
import { EditpetComponent } from './editpet/editpet.component';
import { ShowpetComponent } from './showpet/showpet.component';
import { MainComponent } from './main/main.component';
@NgModule({
  declarations: [AppComponent, CreatepetComponent, EditpetComponent, ShowpetComponent, MainComponent],
  imports: [BrowserModule, AppRoutingModule,HttpClientModule,
    FormsModule],
  providers: [HttpService],
  bootstrap: [AppComponent]
})
export class AppModule { }