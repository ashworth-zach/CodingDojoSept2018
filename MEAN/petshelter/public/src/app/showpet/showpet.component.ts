import { Component, OnInit } from '@angular/core';
import { HttpService } from '../http.service';
import { routerNgProbeToken } from '@angular/router/src/router_module';
import {ActivatedRoute, Router} from '@angular/router';
@Component({
  selector: 'app-showpet',
  templateUrl: './showpet.component.html',
  styleUrls: ['./showpet.component.css']
})
export class ShowpetComponent implements OnInit {
  data:any;
  error='';
  id:any;
  liked:boolean;
  adopted:boolean;

  constructor(private _httpService: HttpService, private route: ActivatedRoute) { }

  ngOnInit() {
    this.liked=false;
    this.adopted=false;
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
        this.data=data['data']

      })
    }
    Like(){
      this.liked=true;
      var observable = this._httpService.Like(this.id);
      observable.subscribe(data=>{
        this.data.likes=data['like']
      })
    }
    Delete(id){
      this.adopted=true;
      var observable=this._httpService.Delete(id);
      observable.subscribe(data=>{
        this.data=data;
      })
    }
}
