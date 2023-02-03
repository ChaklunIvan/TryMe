import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import {LoginComponent} from "./components/login/login.component";
import {TestListComponent} from "./components/test-list/test-list.component";
import {QuestionsComponent} from "./components/questions/questions.component";
import {ResultComponent} from "./components/result/result.component";

const routes: Routes = [
  {path: 'login', component: LoginComponent},
  {path: 'test-list', component: TestListComponent},
  {path: 'questions/:testId', component: QuestionsComponent},
  {path: 'result/:result', component: ResultComponent},
  { path: '**', redirectTo: 'login', pathMatch: 'full'},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
