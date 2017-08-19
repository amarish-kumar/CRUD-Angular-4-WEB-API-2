import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, FormControl, Validators } from '@angular/forms';
import { Product } from "app/model/product.model";
import { ProductService } from "app/model/product.service";
import { Router, ActivatedRoute, Params } from "@angular/router";

import { Response} from "@angular/http";

@Component({
  selector: 'app-form',
  templateUrl: './form.component.html',
  styleUrls: ['./form.component.css']
})
export class FormComponent implements OnInit {
  
  form: FormGroup;
  product = new Product();    
  title: string;
  id: number = 0;
 
  constructor(
    private formBuilder: FormBuilder,
    private ProductService: ProductService,
    private activatedRoute: ActivatedRoute,
    private router: Router
  ) { } 

  ngOnInit(){

    this.activatedRoute.params.subscribe((params: Params) => {
      this.id = params['id'];
    });  

        this.form = this.formBuilder.group({
          name: [null],
          descricao: [null],
          codigo: [null],
          preco: [null],
          email: [null]
        });

        this.title = this.id ? 'Edit Product' : 'New Product';

        if(this.id != undefined) this.onEdit(this.id);   
  }

  onSubmit(){

    this.product.Name = this.form.controls['name'].value;
    this.product.Descricao = this.form.controls['descricao'].value;
    this.product.Codigo = this.form.controls['codigo'].value;
    this.product.Preco = this.form.controls['preco'].value;
    this.product.Email = this.form.controls['email'].value;         
    
    if(this.product.Id){ 
      this.ProductService.updateProduct(this.product).then(() => this.router.navigate(['/list']) );
    }else{
      this.ProductService.addProduct(this.product).then(() => this.router.navigate(['/list']) );
    }
  } 

  onEdit(id: number){

     this.ProductService.getProduct(id).then(response => {
        this.product = response;
        
        this.form.get('name').setValue(this.product.Name);
        this.form.get('descricao').setValue(this.product.Descricao); 
        this.form.get('codigo').setValue(this.product.Codigo); 
        this.form.get('preco').setValue(this.product.Preco); 
        this.form.get('email').setValue(this.product.Email); 
      });
  }

  reset(){
    this.form.reset();
  }
  
}
