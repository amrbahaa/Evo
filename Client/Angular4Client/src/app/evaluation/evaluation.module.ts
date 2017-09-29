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

import { EvaluationSheetComponent } from './evaluation-sheet/evaluation-sheet.component';
import { CandidateInfoFormComponent } from './candidate-info-form/candidate-info-form.component';
import { KpiListFormComponent } from './kpi-list-form/kpi-list-form.component';
import { KpiService } from './kpi.service';

@NgModule({
  imports: [
    MatSliderModule,
    MatInputModule,
    MatAutocompleteModule,
    MatDatepickerModule,
    ReactiveFormsModule,
    FormsModule,
    NgbModule,
    HttpModule,
    CommonModule
  ],
  declarations: [EvaluationSheetComponent, CandidateInfoFormComponent, KpiListFormComponent],
  exports: [EvaluationSheetComponent, CandidateInfoFormComponent, KpiListFormComponent],
  providers: [KpiService]
})
export class EvaluationModule { }
