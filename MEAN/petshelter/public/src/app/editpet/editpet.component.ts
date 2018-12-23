import { Component, OnInit } from '@angular/core';
import { HttpService } from '../http.service';
import { routerNgProbeToken } from '@angular/router/src/router_module';
import {ActivatedRoute, Router} from '@angular/router';
@Component({
  selector: 'app-editpet',
  templateUrl: './editpet.component.html',
  styleUrls: ['./editpet.component.css']
})
export class EditpetComponent implements OnInit {
  editpet:any;
  error='';
  id:any;
  constructor(private _httpService: HttpService, private route: ActivatedRoute,private router: Router) { }

  ngOnInit() {
    this.editpet= {name:'',type:'',description:'',skill1:'',skill2:'',skill3:''}
    var observable=this.route.params;
    observable.subscribe(data=>{
      console.log(data);
      this.id=data.id
      this.findPet(data.id);
    });
  }
    findPet(id){
      var observable = this._httpService.getTask(id);
      observable.subscribe((data)=>{
        console.log(data);
        this.editpet=data['data']
        this.editpet.skill1=data['data']['skills'][0]
        this.editpet.skill2=data['data']['skills'][1]
        this.editpet.skill3=data['data']['skills'][2]

      })
    }
    onSubmit(){
      let observable = this._httpService.editTask(this.editpet,this.id);
      observable.subscribe(data => {
        if(data['message']=='Error'){
          if(data['error']['message']){
  
            this.error=data['error']['message'];
          }
          else{
            this.error=data['error']
          }
        }
        else{
          this.error='';
          this.router.navigate(['/pets'])
        }
        console.log("Got data from post back", data);
      })
    }
}
