import { Component, inject } from '@angular/core';
import { AsyncPipe, CommonModule, NgIf, NgFor } from '@angular/common';
import { RouterOutlet } from '@angular/router';
import { HttpClient, HttpClientModule  } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Contact } from '../Models/contact.mode';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, AsyncPipe, NgIf, HttpClientModule, NgFor ],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  http = inject(HttpClient);

  contacts$ = this.getContacts();

  private getContacts(): Observable<Contact[]> {
    return this.http.get<Contact[]>('https://localhost:7182/api/Contacts');
  }
}
