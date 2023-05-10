import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { devConfig } from "../config/app.config.local";
import { APP_CONFIG } from "../providers/config.provider";
import { UsersListComponent } from './components/users-list/users-list.component';
import { ReactiveFormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,
    UsersListComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule,
    ReactiveFormsModule
  ],
  providers: [{provide: APP_CONFIG, useValue: devConfig}],
  bootstrap: [AppComponent]
})
export class AppModule { }
