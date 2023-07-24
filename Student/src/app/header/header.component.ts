import { Component, OnInit, ViewChild } from '@angular/core';
import { HomeComponent } from '../home/home.component';
import { FormBuilder, FormGroup} from '@angular/forms';



@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit {

button:boolean=false;
  @ViewChild('closebutton') closebutton:any;

  constructor( ){}
  public ngOnInit(){
    
  }
  OnSubmit() {
   // this.activeModal.close();
}
 
}

