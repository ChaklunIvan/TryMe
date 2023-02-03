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

  isAuthenticated: boolean = false;
  showWarning: boolean = false;

  tooltip: string = "Credentials for login:<br>" +
                    "UserName: James007<br>" +
                    "Password: Bond7<br>" +
                    "UserName: ShteinerG42<br>" +
                    "Password: Gate4"

  login(){
    this.loginService.authenticate(this.credentials).subscribe(
      () => {},
      () => {this.showWarning = true;},
      () => {this.loginService.isAuthenticated().subscribe(
        (data: any) => {this.isAuthenticated = data},
        () => {},
        () => this.routeToTests());
    });
  }
  routeToTests(){
    if(this.isAuthenticated){
      this.router.navigate(['test-list'])
    }
    else {
      this.showWarning = true;
    }
  }
}
