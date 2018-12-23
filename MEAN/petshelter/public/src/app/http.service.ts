import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class HttpService {
  constructor(private _http: HttpClient){
   //   this.getTasks();
   }
   getTasks(){
   // our http response is an Observable, store it in a variable
      return this._http.get('/api');
   // subscribe to the Observable and provide the code we would like to do with our data from the response
      
   }
   getTask(task_id){
      console.log('ID is', task_id);
      console.log(task_id);
      // let tempObservable = this._http.get('/api/5a84f4c3d7dee2b8012d96ae');
      // tempObservable.subscribe(data => console.log("Got the task!", data));
      return this._http.get('/api/'+task_id);
    }
    Delete(id){
      return this._http.delete('/api/'+id);
    }
    addTask(newtask){
      return this._http.post('/api', newtask);
    }
    editTask(editTask,id){
      return this._http.patch('/api/'+id, editTask);
    }
    Like(id){
      return this._http.get('/api/'+id+'/like');
    }
  }
