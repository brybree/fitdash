import { Component } from '@angular/core';
import { GroceryListComponent } from '@app/components/grocery-list/grocery-list.component';


@Component({
  selector: 'home',
  standalone: true,
  imports: [GroceryListComponent],
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})
export class HomeComponent {

}
