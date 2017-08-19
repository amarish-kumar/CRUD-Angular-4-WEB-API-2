import { Component, OnInit, TemplateRef } from '@angular/core';
import { Product } from "app/model/product.model";
import { ProductService } from "app/model/product.service";

import { BsModalService } from 'ngx-bootstrap/modal';
//import { BsModalRef } from 'ngx-bootstrap/modal/modal-options.class';
import { BsModalRef } from 'ngx-bootstrap/modal';
import { ModalComponent } from "./modal/modal.component";

@Component({
  selector: 'app-list',
  templateUrl: './list.component.html',
  styleUrls: ['./list.component.css']
})
export class ListComponent implements OnInit {

  products: Product[];
  product: Product;
  bsModalRef: BsModalRef;

  constructor(
    private ProductService: ProductService,
    private modalService: BsModalService
  ) { }

  ngOnInit() {
      this.ProductService.getProducts().then((response) => {
      this.products = response;      
    }); 
  }

  onDelete(name: string, id: number) {
    if(confirm("Você tem certeza que deseja excluir o Produto"+ name +"?")) {            
      this.ProductService.deleteProduct(id).then(response =>  this.ngOnInit() );       
    }
  } 

  onDetails(id: number){      
      
    this.ProductService.getProduct(id).then((response) => {      
       this.product = response;       
       this.bsModalRef = this.modalService.show(ModalComponent); 
       this.bsModalRef.content.title = "Details";                    
       this.bsModalRef.content.product = this.product;                   
    });
  }
}


 
