import { NgModule,CUSTOM_ELEMENTS_SCHEMA  } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ClassComponent } from './class/class.component';
import { SignUpComponent } from './sign-up/sign-up.component';
import { HomeComponent } from './home/home.component';
import { LoginComponent } from './login/login.component';
import { HeaderComponent } from './header/header.component';
import { ProfileComponent } from './profile/profile.component';


const routes: Routes = [
  {path:'Profile',component:ProfileComponent},
  {path:'register',component:ClassComponent},
  {path:'SignUp',component:SignUpComponent},
  {path:'Home',component:HomeComponent},
  {path:'LogIn',component:LoginComponent},
  {path:'',redirectTo:'/Home',pathMatch:'full'}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
  schemas: [ CUSTOM_ELEMENTS_SCHEMA]
})
export class AppRoutingModule { }
