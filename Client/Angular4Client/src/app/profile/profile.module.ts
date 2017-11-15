import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ProfileRoutingModule } from './profile-routing.module';
import { ProfileService } from './profile.service';
import { ProfileDetailsComponent } from './profile-details/profile-details.component';

@NgModule({
  imports: [
    CommonModule,
    ProfileRoutingModule
  ],
  declarations: [ProfileDetailsComponent, ProfileDetailsComponent],
  exports: [ProfileDetailsComponent, ProfileDetailsComponent],
  providers: [ProfileService]
})
export class ProfileModule { }
