import { Component, OnInit } from '@angular/core';
import { HttpService } from './http.service';
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'app';
  tasks = {};
  task = {};
  id = '';
  NewAuthor: any;
  editTask = [];
  showEditForm = false;
  errors="";
  self = this;
  constructor(private _httpService: HttpService) { }
  ngOnInit(){
    this.NewAuthor = { name:"" }
    this.tasksOnClick();

  }
  tasksOnClick() {
    this._httpService.getTasks().subscribe(data => {
      console.log("Got our data!", data)
      this.tasks = data;
      console.log("Got our tasks!", this.tasks)
    })
  }
  showOne(id: String) {
    // get one planet
    // set the planet to the child component using Inputs
  }
  taskOnClick(event: any){
    this.task = [];
    this.id = event.target.value;
    let observable = this._httpService.getTask(this.id)
    observable.subscribe(data => {
      console.log("Clicked the button!", this.id)
      this.task = data;
      console.log("Got our task!", this.task)
    })
  }
  onDelete(id){
    let observable = this._httpService.Delete(id);
    observable.subscribe(data => {
      console.log("Got data from post back", data);
      if(data['error']){

      }
      this.tasksOnClick();
    })
  }
  onSubmit(){
    let observable = this._httpService.addTask(this.NewAuthor);
    observable.subscribe(data => {
      if(data['message']=='Error'){
        this.errors=data['error']['message'];
      }
      else{
        this.errors='';
      }
      console.log("Got data from post back", data);
      this.NewAuthor = {name: ""}
      this.tasksOnClick();
    })
  }
  editOnClick(task){
    console.log("Task we need to edit", task._id);
      console.log("Task to edit", task, "Task title", task.title);
      task.showEditForm = true;
  }
  onEdit(editTask){
    editTask.showEditForm = false;
    console.log("Edit the task", editTask._id)
    let observable = this._httpService.editTask(editTask);
    observable.subscribe(data => {
      console.log("Got data from post back", data);
    })
  }
}
