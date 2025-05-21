import { Component, Input } from '@angular/core';

@Component({
  selector: 'svg-icon',
  standalone: true,
  imports: [],
  templateUrl: './svg-icon.component.html',
  styleUrl: './svg-icon.component.css'
})
export class SvgIconComponent {

  @Input() icon: string | undefined;
}
