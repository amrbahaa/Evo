import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TopNavigationComponent } from './top-navigation/top-navigation.component';

@NgModule({
  imports: [
    CommonModule
  ],
  declarations: [TopNavigationComponent],
  exports: [TopNavigationComponent]
})
export class LayoutModule { }
