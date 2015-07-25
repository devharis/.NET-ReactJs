var PaginationBox = React.createClass({
	render: function() {
	    return (
	        <div className="paginationBox">
	          <h1>Pagination</h1>
	          <PaginationList />
	        </div>
	      );
	  }
});

React.render(
  <PaginationBox />,
  document.getElementById('content')
);