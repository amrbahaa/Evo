import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AssessmentSheetComponent } from './assessment-sheet/assessment-sheet.component';
const routes: Routes = [
  { path: 'assessment', component: AssessmentSheetComponent }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class AssessmentRoutingModule { }
