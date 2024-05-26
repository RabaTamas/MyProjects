package hu.bme.aut.android.recipes.feature.food

import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.recyclerview.widget.RecyclerView
import hu.bme.aut.android.recipes.R
import hu.bme.aut.android.recipes.databinding.ItemFoodBinding

class FoodAdapter(private val listener: OnFoodSelectedListener) : RecyclerView.Adapter<FoodAdapter.FoodViewHolder>() {
    private val foods: MutableList<String> = ArrayList()
    //private val foods: MutableList<FoodItem> = ArrayList()

    interface OnFoodSelectedListener {
        fun onFoodSelected(food: String?)
        //fun onFoodSelected(food: FoodItem?)
    }

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): FoodViewHolder {
        val view = LayoutInflater.from(parent.context).inflate(R.layout.item_food, parent, false)
        return FoodViewHolder(view)
    }

    override fun onBindViewHolder(holder: FoodViewHolder, position: Int) {
        val item = foods[position]
        holder.bind(item)
        /*
        val item = foods[position]
        holder.binding.cbIsMaked.isChecked = item.isMaked
        holder.binding.tvName.text = item.name
        holder.binding.tvCategory.text = item.category.name
        holder.binding.tvTime.text = "${item.estimatedTime} perc"

        holder.binding.cbIsMaked.setOnCheckedChangeListener { buttonView, isChecked ->
            item.isMaked = isChecked
            listener.onItemChanged(item)
        }*/

    }

    /*interface FoodItemClickListener {
        fun onItemChanged(item: FoodItem)
    }*/

    override fun getItemCount(): Int = foods.size

    fun addFood(newFood: String) {
        foods.add(newFood)
        notifyItemInserted(foods.size - 1)
    }

    fun removeFood(position: Int) {
        foods.removeAt(position)
        notifyItemRemoved(position)
        if (position < foods.size) {
            notifyItemRangeChanged(position, foods.size - position)
        }
    }


    /*inner class ShoppingViewHolder(val binding: ItemFoodListBinding) : RecyclerView.ViewHolder(binding.root)*/
    inner class FoodViewHolder(private val itemView: View) : RecyclerView.ViewHolder(itemView) {
        var binding = ItemFoodBinding.bind(itemView)
        var item: String? = null

        init {
            binding.root.setOnClickListener { listener.onFoodSelected(item) }
        }

        fun bind(newFood: String?) {
            item = newFood
            binding.FoodItemNameTextView.text = item
        }
    }
}
