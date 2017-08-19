import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';
import { FormComponent } from "./form/form.component";
import { ListComponent } from "./list/list.component";


const ROUTES: Routes = [
  { path: 'save', component: FormComponent },
  { path: 'save/:id', component: FormComponent },
  { path: 'list', component: ListComponent },
  { path: '', redirectTo: 'list',  pathMatch: 'full'}
  //{ path: '**', component: PageNotFoundComponent }
];

@NgModule({
  imports: [
    CommonModule,
    RouterModule.forRoot(ROUTES)
  ],
  exports:[
    RouterModule
  ],
  declarations: []
})
export class AppRoutingModule { }
