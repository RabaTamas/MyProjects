import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ActorDeatilsComponent } from './actor-deatils.component';

describe('ActorDeatilsComponent', () => {
  let component: ActorDeatilsComponent;
  let fixture: ComponentFixture<ActorDeatilsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ActorDeatilsComponent]
    })
    .compileComponents();
    
    fixture = TestBed.createComponent(ActorDeatilsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
