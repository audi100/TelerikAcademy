// Generated by CoffeeScript 1.4.0
(function() {
  var __hasProp = {}.hasOwnProperty,
    __extends = function(child, parent) { for (var key in parent) { if (__hasProp.call(parent, key)) child[key] = parent[key]; } function ctor() { this.constructor = child; } ctor.prototype = parent.prototype; child.prototype = new ctor(); child.__super__ = parent.prototype; return child; };

  this.GameObject = (function() {

    function GameObject(options) {
      this.attack = options.attack, this.armor = options.armor, this.hitPoints = options.hitPoints, this.range = options.range, this.speed = options.speed;
    }

    return GameObject;

  })();

  this.Warrior = (function(_super) {

    __extends(Warrior, _super);

    function Warrior() {
      Warrior.__super__.constructor.call(this, {
        attack: 8,
        armor: 3,
        hitPoints: 15,
        range: 1,
        speed: 2
      });
    }

    return Warrior;

  })(GameObject);

  this.Ranger = (function(_super) {

    __extends(Ranger, _super);

    function Ranger() {
      Ranger.__super__.constructor.call(this, {
        attack: 8,
        armor: 1,
        hitPoints: 10,
        range: 3,
        speed: 1
      });
    }

    return Ranger;

  })(GameObject);

}).call(this);