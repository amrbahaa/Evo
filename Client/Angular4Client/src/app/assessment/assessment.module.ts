import { Http, HttpModule, JsonpModule } from '@angular/http';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {
  FormsModule,
  ReactiveFormsModule
} from '@angular/forms';

import { NgbModule } from '@ng-bootstrap/ng-bootstrap';

import {
  MatSliderModule,
  MatInputModule,
  MatAutocompleteModule,
  MatDatepickerModule
} from '@angular/material';

import { AssessmentRoutingModule } from './assessment-routing.module';

import { AssessmentSheetComponent } from './assessment-sheet/assessment-sheet.component';
import { CandidateInfoFormComponent } from './candidate-info-form/candidate-info-form.component';
import { KpiListFormComponent } from './kpi-list-form/kpi-list-form.component';
import { KpiService } from './kpi.service';

@NgModule({
  imports: [
    ReactiveFormsModule,
    FormsModule,
    MatSliderModule,
    MatInputModule,
    MatAutocompleteModule,
    MatDatepickerModule,
    NgbModule,
    HttpModule,
    CommonModule,
    AssessmentRoutingModule
  ],
  declarations: [AssessmentSheetComponent, CandidateInfoFormComponent, KpiListFormComponent],
  exports: [AssessmentSheetComponent, CandidateInfoFormComponent, KpiListFormComponent],
  providers: [KpiService]
})
export class AssessmentModule { }
