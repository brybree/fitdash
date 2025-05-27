import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { SvgIconComponent } from '@components/svg-icon/svg-icon.component';

@Component({
  selector: 'programs',
  standalone: true,
  imports: [CommonModule, SvgIconComponent],
  templateUrl: './programs.component.html',
  styleUrl: './programs.component.css'
})
export class ProgramsComponent {

  fake_data = [
    "Upper Body 1",
    "Upper Body 2",  
    "Lower Body 1", 
    "Lower Body 2" ,
    "Full Body 1",
    "Full Body 2",
  ]
}
