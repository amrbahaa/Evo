import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import {
  MatFormFieldModule,
  MatSelectModule,
  MatInputModule,
  MatButtonModule,
} from '@angular/material';

import { FlexLayoutModule } from "@angular/flex-layout";


import { AuthRoutingModule } from './auth-routing.module';
import { LoginComponent } from './login/login.component';
import { AuthService } from './auth.service';

@NgModule({
  imports: [
    FlexLayoutModule,
    MatFormFieldModule,
    MatSelectModule,
    MatInputModule,
    MatButtonModule,
    CommonModule,
    AuthRoutingModule
  ],
  declarations: [LoginComponent],
  exports: [LoginComponent],
  providers: [AuthService]
})
export class AuthModule { }
