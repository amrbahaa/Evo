import { NgModule } from '@angular/core';
import { Routes, RouterModule, PreloadAllModules } from '@angular/router';
import { AppComponent } from './app.component';

const routes: Routes = [
    { path: '', redirectTo: 'assessment', pathMatch: 'full' },
    { path: 'profile', loadChildren: './profile/profile.module#ProfileModule' },
    { path: 'login', loadChildren: './auth/auth.module#AuthModule' },
    { path: 'assessment', loadChildren: './assessment/assessment.module#AssessmentModule' },
];

@NgModule({
    imports: [RouterModule.forRoot(routes, { preloadingStrategy: PreloadAllModules })],
    exports: [RouterModule]
})
export class AppRoutingModule { }
