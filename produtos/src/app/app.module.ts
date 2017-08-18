import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavbarComponent } from './navbar/navbar.component';

//Meu modulo de componente
import { FormModule } from './form/form.module';

import { ReactiveFormsModule, FormsModule } from "@angular/forms";
import { ListComponent } from './list/list.component';
import { AppRoutingModule } from "./app-routing.module";

import { ModalModule } from 'ngx-bootstrap/modal';
//meu modal
import { ModalComponent } from "app/list/modal/modal.component";

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    ListComponent,
    ModalComponent

  ],
  imports: [
    AppRoutingModule, //rota    
    ModalModule.forRoot(),
    BrowserModule,
    FormModule, //meu componente form

    //Para usar os form, tem que importar para ca esses modulos
    FormsModule, 
    ReactiveFormsModule //Necessario para usar o FormBuilder
  ],

  //componentes criados dinamicamentes 
  entryComponents: [
     ModalComponent
  ],
 
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
