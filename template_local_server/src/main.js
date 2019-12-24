import { Triangle } from './triangle';
// import * as Triangle from './triangle.js'

import $ from 'jquery';
import 'bootstrap';
import 'bootstrap/dist/css/bootstrap.min.css';
import './styles.css';

function getSides() {
  var sideA = parseInt($("input#sideA").val());
  var sideB = parseInt($("input#sideB").val());
  var sideC = parseInt($("input#sideC").val());

  var t = new Triangle(sideA, sideB, sideC);

  return t;
}

$(document).ready(function() {

  $("form#triangle").submit(function(event) {

    event.preventDefault();

    var shape = getSides();

    if (shape.isTriangle()) {
      $("#output").text(shape.whichTrinangle());
      $("#output").removeClass("hidden");
    }
    else
      $("#output").removeClass("hidden").text("The dimensions entered do not add up to a triangle");

  });

});
