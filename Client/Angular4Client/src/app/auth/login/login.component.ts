import { Component, OnInit } from '@angular/core';
import { Validators, FormGroup, FormBuilder } from '@angular/forms';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {

  loginForm: FormGroup;

  constructor(private fb: FormBuilder) {
    this.loginForm = fb.group({
      'email': [null, Validators.compose([
        Validators.required,
        Validators.email])]
    });
  }

  ngOnInit() {
  }

  getErrorMessage() {
    const email = this.loginForm.controls['email'];
    return email.hasError('required') ? 'You must enter a value' :
      email.hasError('email') ? 'Not a valid email' :
        '';
  }
}
