import { HttpService } from '../http.service';
import { Component, OnInit } from '@angular/core';
import { routerNgProbeToken } from '@angular/router/src/router_module';
import {ActivatedRoute, Router} from '@angular/router';
@Component({
  selector: 'app-createpet',
  templateUrl: './createpet.component.html',
  styleUrls: ['./createpet.component.css']
})
export class CreatepetComponent implements OnInit {
  self=this;
  newPet:any;
  errors='';
  constructor(private _httpService: HttpService,private router: Router) { }

  ngOnInit() {
    this.newPet={name:'',type:'',description:'',skill1:'',skill2:'',skill3:''}
  }
  onSubmit(){
    let observable = this._httpService.addTask(this.newPet);
    observable.subscribe(data => {
      if(data['message']=='Error'){
        if(data['error']['message']){

          this.errors=data['error']['message'];
        }
        else{
          this.errors=data['error']
        }
      }
      else{
        this.errors='';
        this.router.navigate(['/pets'])
      }
      console.log("Got data from post back", data);
      this.newPet = {name:'',type:'',description:'',skill1:'',skill2:'',skill3:''}
    })
  }
}
