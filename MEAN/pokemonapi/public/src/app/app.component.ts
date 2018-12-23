import { Component } from '@angular/core';
import { HttpService } from './http.service';
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'app';
  pokemon="";
  sprite="";
  allsprites="";
  self = this;
  constructor(private _httpService: HttpService) { }
  // tasksOnClick() {
  //   this._httpService.getPokemon().subscribe(data => {
  //     console.log("Got our data!", data)
  //     this.tasks = data;
  //     var count = 0;
  //     var string = ""
  //     for(var i = 0; i< data['abilities'].length;i++){
  //         this._httpService.getAbility(data['abilities'][i]['ability']['url']).subscribe(data2 =>{
  //           this.task=data2;
  //         })
  //         count=this.task['pokemon'].length;
  //         console.log(count+" other pokemon have the ability "+data['abilities'][i]['ability']['name'])
  //       string+=" "+data['abilities'][i]['ability']['name'];
  //     }
  //     console.log(data['name'] + " has the abilities "+string)
      
  //   })
    
  // }
  taskOnClick(event: any){
    var x = event.target.value;
    console.log(x);
    console.log(event.target.value);
    let observable = this._httpService.getPokemon(x);
    observable.subscribe(data => {
      this.pokemon=data['name'];
      this.sprite=data['sprites']['front_default']
      this.allsprites=data['sprites'];
      console.log(this.pokemon);
      console.log(data);
    })
  }
}
