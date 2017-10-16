import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import {
  MatSliderModule,
  MatInputModule,
  MatAutocompleteModule,
  MatDatepickerModule
} from '@angular/material';

import { TopNavigationComponent } from './top-navigation/top-navigation.component';

@NgModule({
  imports: [
    MatSliderModule,
    MatInputModule,
    MatAutocompleteModule,
    CommonModule
  ],
  declarations: [TopNavigationComponent],
  exports: [TopNavigationComponent, MatInputModule, MatSliderModule]
})
export class LayoutModule { }
