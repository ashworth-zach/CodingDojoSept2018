import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CreatepetComponent } from './createpet.component';

describe('CreatepetComponent', () => {
  let component: CreatepetComponent;
  let fixture: ComponentFixture<CreatepetComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CreatepetComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CreatepetComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
