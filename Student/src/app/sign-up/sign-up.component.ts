import { Component } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { StudentService } from '../Service/student.service';

@Component({
  selector: 'app-sign-up',
  templateUrl: './sign-up.component.html',
  styleUrls: ['./sign-up.component.css']
})
export class SignUpComponent {
  studentformgroup : FormGroup;
  constructor(private Stuservice : StudentService,private fb: FormBuilder){this.studentformgroup = this.fb.group({
    id:[""],
    name:[""],
    PhoneNumber:[""],
    EmailId:[""],
    NewPassword:[""],
    ConfirmPassword:[""]
  })
}

Onsubmit(){
  
    this.Stuservice.CreateStudent(this.studentformgroup.value).subscribe(response=>{
      console.log(response);
      this.studentformgroup.setValue({
        
        id: "",
        name: "",
        PhoneNumber: "",
        EmailId: ""
      })
     });
}

}
