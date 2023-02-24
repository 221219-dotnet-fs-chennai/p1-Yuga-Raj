import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import {MatCardModule} from '@angular/material/card';
import {MatListModule} from '@angular/material/list';
import {MatChipsModule} from '@angular/material/chips';
import {MatIconModule} from '@angular/material/icon';
import { AppComponent } from './app.component';
import {MatProgressBarModule} from '@angular/material/progress-bar';



@NgModule({
    declarations: [
        AppComponent
    ],
    imports: [
        BrowserModule,
        FormsModule,
        BrowserAnimationsModule,
        MatCardModule,
        MatListModule,
        MatChipsModule,
        MatProgressBarModule,
        MatIconModule

    ],
    providers: [],
    bootstrap: [AppComponent]
})
export class AppModule{}