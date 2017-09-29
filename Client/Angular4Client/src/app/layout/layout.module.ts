import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { MatSliderModule, MdInputModule } from '@angular/material';

import { TopNavigationComponent } from './top-navigation/top-navigation.component';

@NgModule({
  imports: [
    MatSliderModule,
    MdInputModule,
    CommonModule
  ],
  declarations: [TopNavigationComponent],
  exports: [TopNavigationComponent]
})
export class LayoutModule { }
