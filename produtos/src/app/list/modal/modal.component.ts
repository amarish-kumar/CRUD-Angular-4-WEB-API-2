import { Component, OnInit } from '@angular/core';
import { BsModalRef } from "ngx-bootstrap/modal";
import { Product } from "app/model/product.model";


@Component({
  selector: 'app-modal',
  templateUrl: './modal.component.html',
  styleUrls: ['./modal.component.css']
})
export class ModalComponent implements OnInit {

  title: string;
  product = new  Product();
 
  constructor(private bsModalRef: BsModalRef) { }

  ngOnInit() {    
    
  }

}
