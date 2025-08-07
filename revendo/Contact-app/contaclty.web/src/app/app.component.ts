import { Component, inject } from '@angular/core';
import { AsyncPipe, CommonModule, NgIf, NgFor } from '@angular/common';
import { RouterOutlet } from '@angular/router';
import { HttpClient, HttpClientModule  } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Contact } from '../Models/contact.mode';
import { FormControl, FormGroup, FormsModule, ReactiveFormsModule } from '@angular/forms';
import { emitDistinctChangesOnlyDefaultValue } from '@angular/compiler';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, AsyncPipe, NgIf, HttpClientModule, NgFor, FormsModule, ReactiveFormsModule],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  http = inject(HttpClient);

  contactsForm = new FormGroup({
    name: new FormControl<string>(''),
    email: new FormControl<string | null>(null),
    phone: new FormControl<string>(''),
    favorite: new FormControl<boolean>(false)
  })

  contacts$ = this.getContacts();

  onFormSubmit() {
    const addContactRequest = {
      name: this.contactsForm.value.name,
      email: this.contactsForm.value.email,
      phone: this.contactsForm.value.phone,
      favorite: this.contactsForm.value.favorite
    }
    this.http.post('https://localhost:7182/api/Contacts', addContactRequest)
    .subscribe({
      next: (value) => {
        console.log(value);
        this.contacts$ = this.getContacts();
        this.contactsForm.reset();
      }
    });
  }

  this.http.delete("");

  private getContacts(): Observable<Contact[]> {
    return this.http.get<Contact[]>('https://localhost:7182/api/Contacts');
  }
}
