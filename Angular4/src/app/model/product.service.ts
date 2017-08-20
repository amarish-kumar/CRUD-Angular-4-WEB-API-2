import { Injectable } from '@angular/core';
import { Http, Response, Headers, RequestOptions } from "@angular/http";
import { Product } from "app/model/product.model";

import 'rxjs/add/operator/toPromise';


@Injectable()
export class ProductService {

    //Adicione aqui seu host SEM PATH ex: http://localhost:51694
   private host: string = "http://localhost:51694";
    
   private url: string = this.host +"/api/product";
   
   public headers: Headers;
   public options: RequestOptions;

  constructor(private http: Http)
   {
       this.headers = new Headers({ 'Content-Type': 'application/json' });
       this.options = new RequestOptions({ headers: this.headers });
   }

   // POST product
    addProduct(product: Product): Promise<Product> {       
        
        return this.http.post(this.url, JSON.stringify(product), this.options  )
               .toPromise()
               .then(response => <Product>response.json())
               .catch(this.handleError)
    }
 
    // PUT product
    updateProduct(product: Product): Promise<void> {       
        
        return this.http.put(this.url, JSON.stringify(product), this.options  )
               .toPromise()
               .then( response => console.log(response) )
               .catch(this.handleError)
    }
    

    // GET ALL product
    getProducts(): Promise<Product[]> {    
        
        return  this.http.get(this.url, this.options )
                .toPromise()
                .then(response => <Product[]>response.json())
                .catch(this.handleError);        
    }

 
    // GET product
    getProduct(id: number): Promise<Product>{
       
      return  this.http.get(this.getUserUrl(id), this.options )
              .toPromise()
              .then(response => <Product>response.json())
              .catch(this.handleError);       
    } 
 
    // DELETE product
    deleteProduct(id: number){
         
      return   this.http.delete(this.getUserUrl(id), this.options )
               .toPromise()
               .then(response => <Product>response.json())
               .catch(this.handleError)
    }    

    //URL with paramiter id
    private getUserUrl(id){
        return this.url + "/" + id;
    }

    private handleError(error: any): Promise<any> {
        console.error('An error occurred', error); 
        return Promise.reject(error.message || error);
    }
}
