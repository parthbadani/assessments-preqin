import { Routes } from '@angular/router';
import { InvestorListComponent } from './investor-list/investor-list.component';

export const routes: Routes = [
    { path: '', redirectTo: '/investors', pathMatch: 'full' },
    { path: 'investors', component: InvestorListComponent }
  ];