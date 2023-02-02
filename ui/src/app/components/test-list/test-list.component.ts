import { Component, OnInit } from '@angular/core';
import {TestService} from "../../services/test.service";
import {Test} from "../../interfaces/test";

@Component({
  selector: 'app-test-list',
  templateUrl: './test-list.component.html',
  styleUrls: ['./test-list.component.css']
})
export class TestListComponent implements OnInit{

  tests: Test[] = [];

  constructor(private testService: TestService) {
  }

  ngOnInit(): void {
  }

  getTests(){
    this.testService.getTestList().subscribe((result: any) =>{
      this.tests = result
    })
  }

}
