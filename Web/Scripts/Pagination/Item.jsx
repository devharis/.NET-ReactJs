var Item = React.createClass({
  render: function() {
    return (
      <div className="item">
	      <h2>
	      	{this.props.Name}
	      </h2>
	      {this.props.children}
      </div>
      );
  }
});
