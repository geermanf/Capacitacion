import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { NewsComponent } from './news.component';
import { AppComponent } from './app.component';
import { SearchComponent } from './search.component';

const routes: Routes = [
  { path: '', redirectTo: 'search', pathMatch: 'full' },
  { path: 'news/:q/:beginDate/:endDate',  component: NewsComponent },
  { path: 'news', redirectTo: 'search', pathMatch: 'full' },
  { path: 'search',  component: SearchComponent }
];

@NgModule({
  imports: [ RouterModule.forRoot(routes) ],
  exports: [ RouterModule ]
})
export class AppRoutingModule {}
