import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { ListGroceriesComponent } from './list-groceries/list-groceries.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, ListGroceriesComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'frontend';
}
