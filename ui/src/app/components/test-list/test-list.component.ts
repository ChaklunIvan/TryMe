import { Component, OnInit } from '@angular/core';
import {TestService} from "../../services/test.service";
import {Test} from "../../interfaces/test";
import {Router} from "@angular/router";

@Component({
  selector: 'app-test-list',
  templateUrl: './test-list.component.html',
  styleUrls: ['./test-list.component.css']
})
export class TestListComponent implements OnInit{

  tests: Test[] = [];

  constructor(private testService: TestService, private router: Router) {
  }

  agreeToStart: boolean = false;

  ngOnInit(): void {
    this.getTests()
  }

  getTests(){
    this.testService.getTestList().subscribe((result: any) =>{
      this.tests = result
    })
  }

  proceedIsDisabled(){
    if(this.agreeToStart == false){
      return true;
    }
    else {
      return false;
    }
  }

  changeAgree(){
    if(this.agreeToStart == true){
      this.agreeToStart = false;
    }
    else {
      this.agreeToStart = true;
    }
  }

  routeToQuestions(testId: number){
    debugger
    this.router.navigate(['${testi}'])
  }
}
