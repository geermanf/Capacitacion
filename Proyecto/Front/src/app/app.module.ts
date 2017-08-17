import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';

import { AppRoutingModule } from './app-routing.module';

import { AppComponent } from './app.component';
import { NewsComponent } from './news.component';
import { SearchComponent } from './search.component';
// import { UserDetailComponent } from './user-detail.component';

import { NewsService } from './news.service';



@NgModule({
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule,
    AppRoutingModule
  ],
  declarations: [
    AppComponent,
    NewsComponent,
    SearchComponent,
  ],
  providers: [ NewsService ],
  bootstrap: [ AppComponent ]
})
export class AppModule { }

