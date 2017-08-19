import { NgModule } from '@angular/core';
import { FormComponent } from './form.component';
import { CommonModule } from "@angular/common";
import { ReactiveFormsModule } from "@angular/forms";
import { ProductService } from "app/model/product.service";
import { HttpModule } from "@angular/http";

@NgModule({
  imports: [
     CommonModule,
     ReactiveFormsModule,
     HttpModule             
  ],
  declarations: [
    FormComponent,    
  ],
  exports: [
    FormComponent
  ],
  providers: [ProductService]
})
export class FormModule { }
