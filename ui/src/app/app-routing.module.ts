import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import {LoginComponent} from "./components/login/login.component";
import {TestListComponent} from "./components/test-list/test-list.component";

const routes: Routes = [
  {path: 'login', component: LoginComponent},
  {path: 'test-list', component: TestListComponent},
  { path: '**', redirectTo: 'login', pathMatch: 'full'},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
