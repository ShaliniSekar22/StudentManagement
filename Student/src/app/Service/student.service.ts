import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Student } from '../models/Student';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class StudentService {

  constructor(private httpclient : HttpClient) { }
  baseurl = "http://localhost:32411/api/Student"

  CreateStudent(stu:Student):Observable<Student>{
    stu.id="00000000-0000-0000-0000-000000000000";
    return this.httpclient.post<Student>(this.baseurl,stu)
  }
}

