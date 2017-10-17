import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AppComponent } from './app.component';

const routes: Routes = [
    { path: 'profile', loadChildren: './profile/profile.module#ProfileModule'},
    { path: 'login', loadChildren: './auth/auth.module#AuthModule'},
    { path: 'assessment', loadChildren: './assessment/assessment.module#AssessmentModule'},
    { path: '', redirectTo: 'assessment', pathMatch: 'full' },
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
})
export class AppRoutingModule { }
