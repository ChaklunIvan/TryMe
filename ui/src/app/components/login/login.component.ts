import { Component } from '@angular/core';
import {LoginService} from "../../services/login.service";
import {Credential} from "../../interfaces/credential";
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {
  constructor(private loginService: LoginService, private router: Router) {}

  credentials: Credential = {
    username: '',
    password: ''
  }

  login(){
    this.loginService.authenticate(this.credentials).subscribe();
    this.router.navigate(["test-list"]);
  }
}
