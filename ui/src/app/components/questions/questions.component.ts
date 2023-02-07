import {Component, OnInit} from '@angular/core';
import {TestService} from "../../services/test.service";
import {ActivatedRoute, Router} from "@angular/router";
import {Question} from "../../interfaces/question";

@Component({
  selector: 'app-questions',
  templateUrl: './questions.component.html',
  styleUrls: ['./questions.component.css']
})
export class QuestionsComponent implements OnInit{

  questions: Question[] = [];
  questionIndex: number = 0;
  testResult: number = 0;
  checkDisabled: boolean = false;

  constructor(protected testService: TestService, private  activatedRoute: ActivatedRoute, private router: Router) {
  }

  ngOnInit(): void {
    let testId = this.activatedRoute.snapshot.params["testId"];
    this.getQuestions(testId);
  }

  getQuestions(testId: number){
    this.testService.getQuestionList(testId).subscribe((result: any) =>{
      this.questions = result;
    })
  }

  nextQuestion(){
    if(this.questionIndex == this.questions.length - 1){
      debugger
      let result = (100 * this.testResult) / this.questions.length;
      this.router.navigate(['result',result])
    }
    else{
      this.questionIndex ++;
    }
    document.querySelectorAll('.form-check-input')
      .forEach(_checkbox=>{
      (<HTMLInputElement>_checkbox).checked = false;
    });
  }

  isChecked(event: any){
    if(event.target.value == "true" && event.target.checked){
      this.disableCheckBox();
      ++this.testResult;
    }
    if(!event.target.checked){
      this.enableCheckBox();
      --this.testResult;
    }
  }

  private disableCheckBox(){
    document.querySelectorAll('.form-check-input')
      .forEach(_checkbox=>{
        if(!(<HTMLInputElement>_checkbox).checked){
          (<HTMLInputElement>_checkbox).disabled = true;
        }
      });
  }

  private enableCheckBox(){
    document.querySelectorAll('.form-check-input')
      .forEach(_checkbox=>{
          (<HTMLInputElement>_checkbox).disabled = false;
      });
  }
}
