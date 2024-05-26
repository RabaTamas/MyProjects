import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SeriesDeatilsComponent } from './series-deatils.component';

describe('SeriesDeatilsComponent', () => {
  let component: SeriesDeatilsComponent;
  let fixture: ComponentFixture<SeriesDeatilsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [SeriesDeatilsComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(SeriesDeatilsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
